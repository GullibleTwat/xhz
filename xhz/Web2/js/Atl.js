/*
 *	sGallery 1.0 - simple gallery with jQuery
 *	made by bujichong 2009-11-25
 *	作者：不羁虫  2009-11-25
 * http://hi.baidu.com/bujichong/
 *	欢迎交流转载，但请尊重作者劳动成果，标明插件来源及作者
 */

(function ($) {
    $.fn.sGallery = function (o) {
        return new $sG(this, o);
        //alert('do');
    };

    var settings = {
        thumbObj: null,//预览对象
        titleObj: null,//标题
        botLast: null,//按钮上一个
        botNext: null,//按钮下一个
        thumbNowClass: 'now',//预览对象当前的class,默认为now
        slideTime: 800,//平滑过渡时间
        autoChange: true,//是否自动切换
        changeTime: 5000,//自动切换时间
        delayTime: 100//鼠标经过时反应的延迟时间
    };

    $.sGalleryLong = function (e, o) {
        this.options = $.extend({}, settings, o || {});
        var _self = $(e);
        var set = this.options;
        var thumb;
        var size = _self.size();
        var nowIndex = 0; //定义全局指针
        var index;//定义全局指针
        var startRun;//预定义自动运行参数
        var delayRun;//预定义延迟运行参数

        //初始化
        _self.eq(0).show();

        //主切换函数
        function fadeAB() {
            if (nowIndex != index) {
                if (set.thumbObj != null) {
                    $(set.thumbObj).removeClass().eq(index).addClass(set.thumbNowClass);
                }
                _self.eq(nowIndex).stop(false, true).fadeOut(set.slideTime);
                _self.eq(index).stop(true, true).fadeIn(set.slideTime);
                $(set.titleObj).eq(nowIndex).hide();//新增加title
                $(set.titleObj).eq(index).show();//新增加title
                nowIndex = index;
                if (set.autoChange == true) {
                    clearInterval(startRun);//重置自动切换函数
                    startRun = setInterval(runNext, set.changeTime);
                }
            }
        }

        //切换到下一个
        function runNext() {
            index = (nowIndex + 1) % size;
            fadeAB();
        }

        //点击任一图片
        if (set.thumbObj != null) {
            thumb = $(set.thumbObj);
            //初始化
            thumb.eq(0).addClass(set.thumbNowClass);
            thumb.bind("mousemove", function (event) {
                index = thumb.index($(this));
                fadeAB();
                delayRun = setTimeout(fadeAB, set.delayTime);
                clearTimeout(delayRun);
                event.stopPropagation();
            })
        }

        //点击上一个
        if (set.botNext != null) {
            var botNext = $(set.botNext);
            botNext.mousemove(function () {
                runNext();
                return false;
            });
        }

        //点击下一个
        if (set.botLast != null) {
            var botLast = $(set.botLast);
            botLast.mousemove(function () {
                index = (nowIndex + size - 1) % size;
                fadeAB();
                return false;
            });
        }

        //自动运行
        if (set.autoChange == true) {
            startRun = setInterval(runNext, set.changeTime);
        }

    }

    var $sG = $.sGalleryLong;

})(jQuery);

function slide(Name, Class, Width, Height, fun) {
    $(Name).width(Width);
    $(Name).height(Height);

    if (fun == true) {
        $(Name).append('<div class="title-bg"></div><div class="title"></div><div class="change"></div>')
        var atr = $(Name + ' div.changeDiv a');
        var sum = atr.length;
        for (i = 1; i <= sum; i++) {
            var title = atr.eq(i - 1).attr("title");
            var href = atr.eq(i - 1).attr("href");
            $(Name + ' .change').append('<i>' + i + '</i>');
            $(Name + ' .title').append('<a href="' + href + '">' + title + '</a>');
        }
        $(Name + ' .change i').eq(0).addClass('cur');
    }
    $(Name + ' div.changeDiv a').sGallery({//对象指向层，层内包含图片及标题
        titleObj: Name + ' div.title a',
        thumbObj: Name + ' .change i',
        thumbNowClass: Class
    });
    $(Name + " .title-bg").width(Width);
}

//缩略图
jQuery.fn.LoadImage = function (scaling, width, height, loadpic) {
    if (loadpic == null) loadpic = "../images/msg_img/loading.gif";
    return this.each(function () {
        var t = $(this);
        var src = $(this).attr("src")
        var img = new Image();
        img.src = src;
        //自动缩放图片
        var autoScaling = function () {
            if (scaling) {
                if (img.width > 0 && img.height > 0) {
                    if (img.width / img.height >= width / height) {
                        if (img.width > width) {
                            t.width(width);
                            t.height((img.height * width) / img.width);
                        } else {
                            t.width(img.width);
                            t.height(img.height);
                        }
                    }
                    else {
                        if (img.height > height) {
                            t.height(height);
                            t.width((img.width * height) / img.height);
                        } else {
                            t.width(img.width);
                            t.height(img.height);
                        }
                    }
                }
            }
        }
        //处理ff下会自动读取缓存图片
        if (img.complete) {
            autoScaling();
            return;
        }
        $(this).attr("src", "");
        var loading = $("<img alt=\"加载中...\" title=\"图片加载中...\" src=\"" + loadpic + "\" />");

        t.hide();
        t.after(loading);
        $(img).load(function () {
            autoScaling();
            loading.remove();
            t.attr("src", this.src);
            t.show();
            //$('.photo_prev a,.photo_next a').height($('#big-pic img').height());
        });
    });
}

//向上滚动代码
function startmarquee(elementID, h, n, speed, delay) {
    var t = null;
    var box = '#' + elementID;
    $(box).hover(function () {
        clearInterval(t);
    }, function () {
        t = setInterval(start, delay);
    }).trigger('mouseout');
    function start() {
        $(box).children('ul:first').animate({ marginTop: '-=' + h }, speed, function () {
            $(this).css({ marginTop: '0' }).find('li').slice(0, n).appendTo(this);
        })
    }
}

//TAB切换
function SwapTab(name, title, content, Sub, cur) {
    $(name + ' ' + title).mouseover(function () {
        $(this).addClass(cur).siblings().removeClass(cur);
        $(content + " > " + Sub).eq($(name + ' ' + title).index(this)).show().siblings().hide();
    });
}

$(document).ready(function () {
    //获取锚点即当前图片id
    var picid = location.hash;
    picid = picid.substring(1);
    if (isNaN(picid) || picid == '' || picid == null) {
        picid = 1;
    }
    picid = parseInt(picid);

    //图集图片总数
    var totalnum = $("#pictureurls li").length;
    //如果当前图片id大于图片数，显示第一张图片
    if (picid > totalnum || picid < 1) {
        picid = 1;
        next_picid = 1;	//下一张图片id
    } else {
        next_picid = picid + 1;
    }

    url = $("#pictureurls li:nth-child(" + picid + ") img").attr("rel");
    $("#big-pic").html("<img src='" + url + "' onload='loadpic(" + next_picid + ")'>");
    $('#big-pic img').LoadImage(true, 890, 650, $("#load_pic").attr('rel'));
    $("#picnum").html("(" + picid + "/" + totalnum + ")");
    $("#picinfo").html($("#pictureurls li:nth-child(" + picid + ") img").attr("alt"));

    $("#pictureurls li").click(function () {
        i = $(this).index() + 1;
        showpic(i);
    });

    //加载时图片滚动到中间
    var _w = $('.cont li').width() * $('.cont li').length;
    if (picid > 2) {
        movestep = picid - 3;
    } else {
        movestep = 0;
    }
    $(".cont ul").css({ "left": -+$('.cont li').width() * movestep });

    //点击图片滚动
    $('.cont ul').width(_w);
    $(".cont li").click(function () {
        if ($(this).index() > 2) {
            movestep = $(this).index() - 2;
            $(".cont ul").css({ "left": -+$('.cont li').width() * movestep });
        }
    });
    //当前缩略图添加样式
    $("#pictureurls li:nth-child(" + picid + ")").addClass("on");

});

$(document).keyup(function (e) {
    var currKey = 0, e = e || event;
    currKey = e.keyCode || e.which || e.charCode;
    switch (currKey) {
        case 37: // left
            showpic('pre');
            break;
        case 39: // up
            showpic('next');
            break;
        case 13: // enter
            var nextpicurl = $('#nextPicsBut').attr('href');
            if (nextpicurl !== '' || nextpicurl !== 'null') {
                window.location = nextpicurl;
            }
            break;
    }
});


function showpic(type, replay) {
    //隐藏重复播放div
    $("#endSelect").hide();

    //图集图片总数
    var totalnum = $("#pictureurls li").length;
    if (type == 'next' || type == 'pre') {
        //获取锚点即当前图片id
        var picid = location.hash;
        picid = picid.substring(1);
        if (isNaN(picid) || picid == '' || picid == null) {
            picid = 1;
        }
        picid = parseInt(picid);

        if (type == 'next') {
            i = picid + 1;
            //如果是最后一张图片，指针指向第一张
            if (i > totalnum) {
                $("#endSelect").show();
                i = 1;
                next_picid = 1;
                //重新播放
                if (replay != 1) {
                    return false;
                } else {
                    $("#endSelect").hide();
                }
            } else {
                next_picid = parseInt(i) + 1;
            }

        } else if (type == 'pre') {
            i = picid - 1;
            //如果是第一张图片，指针指向最后一张
            if (i < 1) {
                i = totalnum;
                next_picid = totalnum;
            } else {
                next_picid = parseInt(i) - 1;
            }
        }
        url = $("#pictureurls li:nth-child(" + i + ") img").attr("rel");
        $("#big-pic").html("<img src='" + url + "' onload='loadpic(" + next_picid + ")'>");
        $('#big-pic img').LoadImage(true, 890, 650, $("#load_pic").attr('rel'));
        $("#picnum").html("(" + i + "/" + totalnum + ")");
        $("#picinfo").html($("#pictureurls li:nth-child(" + i + ") img").attr("alt"));
        //更新锚点
        location.hash = i;
        type = i;

        //点击图片滚动
        var _w = $('.cont li').width() * $('.cont li').length;
        if (i > 2) {
            movestep = i - 3;
        } else {
            movestep = 0;
        }
        $(".cont ul").css({ "left": -+$('.cont li').width() * movestep });
    } else if (type == 'big') {
        //获取锚点即当前图片id
        var picid = location.hash;
        picid = picid.substring(1);
        if (isNaN(picid) || picid == '' || picid == null) {
            picid = 1;
        }
        picid = parseInt(picid);

        url = $("#pictureurls li:nth-child(" + picid + ") img").attr("rel");
        window.open(url);
    } else {
        url = $("#pictureurls li:nth-child(" + type + ") img").attr("rel");
        $("#big-pic").html("<img src='" + url + "'>");
        $('#big-pic img').LoadImage(true, 890, 650, $("#load_pic").attr('rel'));
        $("#picnum").html("(" + type + "/" + totalnum + ")");
        $("#picinfo").html($("#pictureurls li:nth-child(" + type + ") img").attr("alt"));
        location.hash = type;
    }

    $("#pictureurls li").each(function (i) {
        j = i + 1;
        if (j == type) {
            $("#pictureurls li:nth-child(" + j + ")").addClass("on");
        } else {
            $("#pictureurls li:nth-child(" + j + ")").removeClass();
        }
    });
}
//预加载图片
function loadpic(id) {
    url = $("#pictureurls li:nth-child(" + id + ") img").attr("rel");
    $("#load_pic").html("<img src='" + url + "'>");
}