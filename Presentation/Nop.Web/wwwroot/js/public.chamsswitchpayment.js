var amount = $('#modelAmount').text();
console.log(amount);
var firstname = $('#modelFirstName').text();
console.log(firstname);
var lastname = $('#modelLastName').text();
console.log(lastname);
var email = $('#modelEmail').text();
console.log(email);
var phonenumber = $('#modelPhoneNumber').text();
console.log(phonenumber);
var description = $('#modelDescription').text();
console.log(description);
var status = $('#modelStatus').text();
console.log(status);
var customerid = parseInt($('#modelCustomerID').text());
console.log(customerid);
var orderGUID = $('#modelOrderGUID').text();
console.log(orderGUID);


// payment status for voided or successful payments.
var statusid = 0;

var redirect = {
    makePayment: function () {

        var rnd = "CAPDAN-" + Date.now();
        getpaidSetup({
            customer_email: email,
            customer_firstname: firstname,
            customer_phone: phonenumber,
            customer_lastname: lastname,
            amount: amount,
            currency: "NGN",
            country: "NG",
            //payment_method: "card",
            custom_logo: "http://imgur.com/uuRnkV9",
            custom_description: description,
            //custom_title: "The Start",
            txref: rnd,
            //integrity_hash: "<PASS YOUR GENERATED INTEGRITY HASH HERE>",//
            // PBFPubKey: "FLWPUBK-b33ae312fb7ee1271fcb8ac5bd1a7bfe-X",
            PBFPubKey: "FLWPUBK-ba31adf2a7e184527f914e7bc8134b18-X",
            onclose: function (response) {
                //update payment status
                if (triggerPayment == false) {
                    //updatePaymentInfo(activepayId, 0, "Cancelled");
                    alert('Payment Cancelled..');
                }
                return false;
            },
            callback: function (response) {
                // collect flwRef returned and pass to a  server page to complete status check.
                var flw_ref = response.tx.flwRef;
                console.log("This is the response returned after a charge", response);

                triggerPayment = true;

                if (response.tx.chargeResponse == '00' || response.tx.chargeResponse == '0') {
                    statusid = 50; // for voided payments.
                    alert('An error returned during processing.')
                    //return back to the check out page.
                    updatePaymentInfo(statusid, customerid, orderGUID);
                    // redirect to a failure page.
                    return true;
                } else {
                    statusid = 30; // for successful payments.
                    updatePaymentInfo(statusid, customerid, orderGUID);
                    //updatePaymentInfo(statusid, customerid, orderGUID);
                    alert('Payment Successful..' + flw_ref);
                    // $('#transRefID').val() = flw_ref;
                    return false;
                }
            },


            // update the order.paymentstatus table by customerid.
            //updatePaymentInfo: function (statusid, customerid, orderGUID) {
            

        });

        return false;
    }
}


function updatePaymentInfo(statusid, customerid, orderGUID) {
    //"{statusid: '" + statusid + "', customerid:  '" + customerid + "', orderGUID:'" + orderGUID + "' }"
    //"{\"paymentstatusid\": " + statusid + ", \"customerid\": " + customerid + ", \"orderguid\": \"" + orderGUID + "\"}"
    var request = {
        data: { paymentstatusid: statusid, customerid: customerid, orderguid: orderGUID }
    };
    $.ajax({
        type: "POST",
        url: "http://localhost:57916/paymentservice.asmx/UpdatePaymentDetails",
        data: JSON.stringify(request),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
      //  async: true,
        success: function (result) {

            if (result.d != "") {
                var data = JSON.parse(result.d);
                if (data.length != 0) {
                    console.log(data);
                }
            }
        },
        error: function (err) {
            console.log(err);
        }

    });
}




