// JavaScript source code
function DataService() {
    // Displaying Items - using a REST API request and created dynamically from that call.
    var self = this;
    self.getAllItems = function (callback, errorCallback) {
        $.ajax({
            url: " http://vending.us-east-1.elasticbeanstalk.com/items",
            method: "GET",
            headers: {
                "accept": "application/json"
            },
            success: callback,
            error: errorCallback
        });
    };

    //	 http://vending.us-east-1.elasticbeanstalk.com /money/{amount}/item/{id}
    self.getItemByID = function (itemID, amount, callback, errorCallback) {
        $.ajax({
            url: " http://vending.us-east-1.elasticbeanstalk.com/money/" + amount + "/item/" + itemID,
            method: "POST",
            headers: {
                "accept": "application/json"
            },
            success: callback,
            error: errorCallback
        });
    }
}