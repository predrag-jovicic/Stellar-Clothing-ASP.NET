function markProductWhichIsNotAvailable(id) {
    products = document.getElementsByClassName("cart-header");
    for (var product of products) {
        if ($(product).find(".close1").data("id") == id) {
            $(product).find(".cart-item-info").html("<h2>The product is not available anymore for the quantity you've chosen.</h2>");
            $(product).css("background-color", "gainsboro");
            $(product).css("border-radius", "8px");
        }
    }
}
$("#orderbtn").on("click", function () {
    $.ajax({
        url: "api/OrderApi",
        type: "POST",
        headers: {
            "RequestVerificationToken": document.getElementById('RequestVerificationToken').value
        },
        success: function () {
            $(".cart-items .container").html("Your order has been placed");
        },
        error: function (xhr) {
            switch (xhr.status) {
                case 500:
                    $(".cart-items .container").html("Server error");
                    break;
                case 409:
                    var id = xhr.responseText;
                    markProductWhichIsNotAvailable(id);
                    break;
            }
        }
    });
});
$(".close1").on("click", function (e) {
    e.preventDefault();
    var reference = $(this);
    var id = reference.data("id");
    $.ajax({
        url: "/api/products/removeitem/" + id,
        type: "DELETE",
        headers: {
            "RequestVerificationToken": document.getElementById('RequestVerificationToken').value
        },
        success: function () {
            var subtotalprice = parseFloat(reference.parent().find(".subtotalprice").text().split("€")[1]);
            var totalprice = parseFloat($("#totalprice").text().split("€")[1]);
            if (totalprice - subtotalprice <= 0) {
                $(".cart-items .container").html("You erased all the products from your shopping cart");
                $("#simpleCart_quantity").text("Cart - €0");
            }
            else {
                $("#totalprice").html("€" + (totalprice - subtotalprice));
                $("#simpleCart_quantity").text("Cart - " + (totalprice - subtotalprice));
            }
            reference.parent().remove();
        },
        error: function () {
            alert("An error occurred.");
        }
    });
});
$("#eraseallbtn").on("click", function () {
    $.ajax({
        url: "/api/products/emptycart",
        type: "DELETE",
        headers: {
            "RequestVerificationToken": document.getElementById('RequestVerificationToken').value
        },
        success: function () {
            $(".cart-items .container").html("You erased all the products from your shopping cart");
            $("#simpleCart_quantity").text("Cart - €0");
        },
        error: function () {
            alert("An error occurred.");
        }
    });
});