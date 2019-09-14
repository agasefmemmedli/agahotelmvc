(function ($) {




    //function setInputFilter(textbox, inputFilter) {
    //    ["input", "keydown", "keyup", "mousedown", "mouseup", "select", "contextmenu", "drop"].forEach(function (event) {
    //        textbox.addEventListener(event, function () {
    //            if (inputFilter(this.value)) {
    //                this.oldValue = this.value;
    //                this.oldSelectionStart = this.selectionStart;
    //                this.oldSelectionEnd = this.selectionEnd;
    //            } else if (this.hasOwnProperty("oldValue")) {
    //                this.value = this.oldValue;
    //                this.setSelectionRange(this.oldSelectionStart, this.oldSelectionEnd);
    //            }
    //        });
    //    });
    //}


    //// Install input filters.
    //setInputFilter(document.getElementById("uintTextBox"), function (value) {
    //    return /^\d*$/.test(value);
    //});

    $("[data-target='#searchroom']").click(function () {
        var searchtext = $("#uintTextBox").val();
        $.ajax({
            url: "/reception/RoomsSearch?txt=" + searchtext,
            type: "get",
            dataType: "html",
            success: function (response) {
                $(".js-basic-example").empty();
                $(".js-basic-example").html(response);

            },
            error: function (error) {
                console.log(error);
            }
        });
    });




    $("#searchproduct").click(function () {
        var searchtext = $("#searchtxt").val();
        $.ajax({
            url: "/restoran/NewOrderSearch?txt=" + searchtext,
            type: "get",
            dataType: "html",
            success: function (response) {
                $(".searchbody").empty();
                $(".searchbody").html(response);

            },
            error: function (error) {
                console.log(error);
            }
        });
    });

    $("[data-target='#searchproducttxt']").click(function () {
        var searchtext = $("#uintTextBox").val();
        $.ajax({
            url: "/restoran/ProductsSearch?txt=" + searchtext,
            type: "get",
            dataType: "html",
            success: function (response) {
                $(".js-basic-example").empty();
                $(".js-basic-example").html(response);

            },
            error: function (error) {
                console.log(error);
            }
        });
    });


    $(".btn-add-tolist").click(function () {
        /*    alert($(this).attr('id'));*/
        var count = $(this).parent().siblings('.count');

        var price = $(this).parent().siblings('.price').children("span").text();
        if (count.text() != 0)
        {
            count.text(count.text() - 1);
        }


       
    });

    $(".save-order").click(function () {
        var productList = [];

        var list = $(".order-list");
        var firstEl = $(":first-child", list)
        for (var i = 0; i < list.children().length; i++)
        {
           var first= firstEl.find(".invoice-count");
            var z = [];
            z.push(first.text());
            z.push(first.attr('id'));
            productList.push(z);
            firstEl = firstEl.next();
        }

        console.log(productList);






        $.ajax({
            url: "/restoran/ProductsSearch?txt=" + searchtext,
            type: "get",
            dataType: "html",
            success: function (response) {
                $(".js-basic-example").empty();
                $(".js-basic-example").html(response);

            },
            error: function (error) {
                console.log(error);
            }
        });
    });



    $(".add-invoice").click(function () {
        
        var Id = $(this).attr("id");
        $.ajax({
            url: "/restoran/AddToList?Id=" + Id,
            type: "get",
            dataType: "html",
            success: function (response) {
                //$(".js-basic-example").empty();
                $(response).find("#id")
                $(".order-list").append(response);

            },
            error: function (error) {
                console.log(error);
            }
        });
    });

    




})(jQuery);