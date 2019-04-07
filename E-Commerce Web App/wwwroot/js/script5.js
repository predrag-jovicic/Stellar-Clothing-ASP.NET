var variantId;
$(document).ready(function () {
    var productID = $("#itemID").val();
    var sizeSelected = false;
    var colorSelected = false;
    var sizeID;
    var colorID;
    $(".productsize").on("click", function (e) {
        e.preventDefault();
        sizeSelected = true;
        $(".productsize").css("color", "black");
        $(this).css("color", "orange");
        sizeID = $(this).attr("value");
        if (colorsAvailable)
            getAvailableColors();
        else
            getAvailableAmountSizeChosen();
    });
    $(document).on("click", ".productcolor", function (e) {
        e.preventDefault();
        colorSelected = true;
        $(".productcolor").css("border", "0.5px solid black");
        $(this).css("border", "1px solid orange");
        colorID = $(this).attr("value");
        if (sizeSelected)
            getAvailableAmountSizeAndColorChosen();
        else
            getAvailableAmountColorChosen();
    });
    $(".rating span").on("click", ratingfun);
    function ratingfun() {
        $(".rating span").css("color", "black");
        $(this).css("color", "gold");
        $(this).nextAll().css("color", "gold");
        var rating = $(this).nextAll().length + 1;
        $.ajax({
            headers: {
                "RequestVerificationToken": document.getElementById('RequestVerificationToken').value
            },
            url: "/api/RatingsApi/rateproduct",
            type : "POST",
            data : {
                value : rating,
                productId : productID
            },
            success : function(){
                alert("You've successfully rated the product.");
            },
            error : function(xhr){
                switch(xhr.status){
                    case 401:
                        alert("You must be logged in to rate a product.");
                        break;
                    case 409:
                        alert("You 've already voted");
                        break;
                    case 422:
                        alert("Incorrect data");
                        break;
                    case 500:
                        alert("Server error");
                        break;
                }
            }
        });
        $(".rating span").off("click", ratingfun);
    }
    $(".add-cart.item_add").on("click", function (e) {
        addToCart();
    });
    function addToCart() {
        if (variantId === undefined) {
            alert("You have to select product's size/color first.");
            return;
        }
        var quantity = $("#quantity").val();
        $.ajax({
            headers: {
                "RequestVerificationToken": document.getElementById('RequestVerificationToken').value
            },
            type : "POST",
            url: "/api/products/addtocart",
            dataType: "JSON",
            data: {
                productVariantId: variantId,
                quantity : quantity
            },
            success: function(){
                $("#popupproduct").slideDown();
                $("#popupproduct p").text("The product has been added to the shopping cart.");
                $("#simpleCart_quantity").text("Cart - A new product has been added");
            },
            error: function(xhr){
                switch(xhr.status){
                    case 401:
                        pojavljivanjePopUp();
                        $("#popupproduct p").text("You have to be logged in to add an item to the shopping cart");
                        break;
                }
            }
        });
    }
    function pojavljivanjePopUp(){
        $("#popupproduct").slideToggle();
    }
    function nestajanjePopUp() {
        $("#popupproduct").animate({ width: "0rem", opacity: "0" }, 1000);
        setTimeout(function () {$("#popupproduct").hide(); $("#popupproduct").css("width","50rem"); $("#popupproduct").css("opacity","1");}, 1500);
    }
    $(".closeButton").click(nestajanjePopUp);
    $("#okdugme").click(nestajanjePopUp);
    $(".sb-search-submit").click(function (e) {
        if (!$(".sb-search-input").val())
            e.preventDefault();
        $(".sb-search-input").fadeIn("fast");
    });
    function getAvailableAmountColorChosen() {
        $.ajax({
            url: "/api/products/amount",
            type: "GET",
            dataType: "JSON",
            data: {
                productID: productID,
                colorID: colorID
            },
            success: function (data, xhr) {
                amountOutput(data);
            },
            error: function (xhr, statusTxt) {
                console.log(xhr.status);
            }
        }); 
    }
    function getAvailableAmountSizeChosen() {
        $.ajax({
            url: "/api/products/amount",
            type: "GET",
            dataType: "JSON",
            data: {
                productID: productID,
                sizeID: sizeID
            },
            success: function (data, xhr) {
                amountOutput(data);
            },
            error: function (xhr, statusTxt) {
                console.log(xhr.status);
            }
        });
    }
    function getAvailableAmountSizeAndColorChosen() {
        $.ajax({
            url: "/api/products/amount",
            type: "GET",
            dataType: "JSON",
            data: {
                productID: productID,
                colorID: colorID,
                sizeID: sizeID
            },
            success: function (data, xhr) {
                amountOutput(data);
            },
            error: function (xhr, statusTxt) {
                console.log(xhr.status);
            }
        });
    }
    function getAvailableColors() {
        $.ajax({
            url: "/api/products/getAvailableColors",
            type: "GET",
            dataType: "JSON",
            data: {
                productID: productID,
                sizeID: sizeID
            },
            success: function (data, xhr) {
                fetchColors(data);
            },
            error: function (xhr, statusTxt) {
                console.log(xhr.status);
            }
        });
    }
    function amountOutput(data) {
        $("#quantity").val(1);
        $("#quantity").attr("max", data.amount);
        variantId = data.productVariantId;
        $("#quantity").on("blur", function () {
            if (Number($("#quantity").val()) <= 0 || Number($("#quantity").val()) > Number($("#quantity").attr("max"))) {
                $("#quantity").css("border", "1px solid red");
            }
            else {
                $("#quantity").css("border", "1px solid gray");
            }
        });
    }
    function fetchColors(data) {
        var output = '<h3>Color</h3><div id="fetchcolors">';
        for (let color of data) {
            output += '<li><a href="#"><div class="productcolor" id="' + color.name +'" value="'+ color.color_id +'"></div></a></li>';
        }
        output += '</div>';
        document.getElementsByClassName("chooseoption")[1].innerHTML = output;
    }
});