﻿(function ($) {




    function setInputFilter(textbox, inputFilter) {
        ["input", "keydown", "keyup", "mousedown", "mouseup", "select", "contextmenu", "drop"].forEach(function (event) {
            textbox.addEventListener(event, function () {
                if (inputFilter(this.value)) {
                    this.oldValue = this.value;
                    this.oldSelectionStart = this.selectionStart;
                    this.oldSelectionEnd = this.selectionEnd;
                } else if (this.hasOwnProperty("oldValue")) {
                    this.value = this.oldValue;
                    this.setSelectionRange(this.oldSelectionStart, this.oldSelectionEnd);
                }
            });
        });
    }


    // Install input filters.
    setInputFilter(document.getElementById("uintTextBox"), function (value) {
        return /^\d*$/.test(value);
    });

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

})(jQuery);