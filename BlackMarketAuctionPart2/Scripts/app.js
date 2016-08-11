/*
     app.ts
     Austin Cameron - Patrick Ross - Ryan Jameson
     Black Market Auction House
     This is the custom typescript page

*/
(function () {
    var cartValue;
    var hasDeletion = false;
    // Document.ready -> link up remove event handler
    $(".RemoveLink").click(function () {
        // Get the id from the link
        var recordToDelete = $(this).attr("data-id");
        if (recordToDelete != '') {
            // Perform the ajax post
            $.post("/ShoppingCart/RemoveFromCart/" + recordToDelete, function (data) {
                // Successful requests get here
                // Update the page elements
                if (data.ItemCount == 0) {
                    $('#row-' + data.DeleteID).fadeOut('slow');
                }
                else {
                    $('#item-count-' + data.DeleteID).text(data.ItemCount);
                }
                $('#cart-total').text(data.CartTotal);
                cartValue = data.cartTotal;
                hasDeletion = true;
                $('#update-message').text(data.Message);
                $('#cart-status').text('Cart (' + data.CartCount + ')');
            });
        }
    });
    if (!hasDeletion) {
        cartValue = $("#shoppingCart").html();
    }
    $("#shoppingCart").html(" <span class='badge'> " + cartValue + " </span>");
})();
//# sourceMappingURL=app.js.map