(function ($) {

    invoiceFullPrice();


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
    var product = $(".hidden-product");
    product.hide();

    //search room in rooms
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


    // search product in new order list for ajax


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


    // search product in product list for ajax

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

    // minus product count

    $(".btn-add-tolist").click(function () {
        /*    alert($(this).attr('id'));*/
        var count = $(this).parent().siblings('.count');

        var price = $(this).parent().siblings('.price').children("span").text();
        if (count.text() != 0)
        {
            count.text(count.text() - 1);
        }


       
    });

    // send invoice to backend

    $(".save-order").click(function () {
        var productList = []

        var list = $(".order-list");
        var firstEl = $(":first-child", list)
        for (var i = 0; i < list.children().length; i++)
        {
           var first= firstEl.find(".invoice-count");
            var z = {};
            var selectCustId = $(".select-cust-name");
            console.log(selectCustId.attr("id"));
            z = { Id: first.attr("id"), Count: first.text(), CustId: selectCustId.attr("id")};
            productList.push(z);
            firstEl = firstEl.next();
        }
        console.log(productList);
        $.ajax({
            url: "/restoran/SaveOrder",
            type: "post",
            data: { 'productList':productList },
            success: function (response) {
                location.reload();
            },
            error: function (error) {
                console.log(error);
            }
        });
    });


    //add new product in invoice and calc price
    $(".add-invoice").click(function () {

        var Id = $(this).attr("id");
        var list = $(".order-list");
        var exist = true;
        var firstEl = $(":first-child", list)
        for (var i = 0; i < list.children().length; i++) {
            var count = firstEl.find(".invoice-count");

            var price = firstEl.children().find(".invoice-price");
            var fullprice = firstEl.children().find(".invoice-fullprice");
            var firstId = count.attr("id");

            if (Id == firstId)
            {
                count.text(parseInt(count.text()) + 1);
                exist = false;

                fullprice.text(parseInt(count.text()) * parseInt(price.text()))
            }
            calctotalprice();
            firstEl = firstEl.next();
            invoiceFullPrice();

        }

        // add new product if his not has in list
        if (exist)
        {
            $.ajax({
                url: "/restoran/AddToList?Id=" + Id,
                type: "get",
                dataType: "html",
                success: function (response) {
                    $(".order-list").append(response);
                    calctotalprice();
                    invoiceFullPrice();
                },
                error: function (error) {
                    console.log(error);
                }
            });
        }
        

    });


    // calc total price
    function calctotalprice()
    {
        var list = $(".order-list");
        var total = $(".total-price");
        total.text(0);
        var firstEl = $(":first-child", list)
        for (var i = 0; i < list.children().length; i++) {

            var fullprice = firstEl.children().find(".invoice-fullprice");
            total.text(parseInt(total.text()) + parseInt(fullprice.text()));

            firstEl = firstEl.next();

        }
    }

    //show and hidden invoice
    function invoiceFullPrice() {
        var list = $(".order-list");
        if (list.children().length > 0) {
            $(".invoice").show();

        }
        else {
            $(".invoice").hide();

        }
    }

    //show and hidden invoice
    function showProductList() {
        var product = $(".hidden-product");
        product.show()
        
    }




    $(".select-cust").click(function () {

        var Id = $(this).attr("id");
        var cust = $(this).parent().parent();
        var name = cust.find(".cust-name");
        var selectcus = $(".select-cust-name");
        selectcus.text("");
        selectcus.text(name.text());
        selectcus.attr("id", Id);
        showProductList();
        $("[data-target='#selectcustomer']").attr("disabled", "");
        $('.close-modal').trigger('click');
    });


    $(".send-invoice").click(function () {

        var total = $(".total-price");
        var modaltot = $(".modal-totalprice");
        modaltot.text(total.text());
        var selectcusmodal = $(".cust-name-modal-invoice");
        selectcusmodal.text($(".select-cust-name").text());
    });
})(jQuery);