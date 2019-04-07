$(document).ready(function(){   
    setTimeout(function(){
        $(".register-top-grid").animate({right:"0",opacity:"1"},1200);
        $(".register-bottom-grid").animate({left:"0",opacity:"1"},1200);
        $(".register input[type='button']").fadeIn(1300);
    },700);
    //regular expressions
    var reName = /^[A-Z][a-z]{2,15}$/;
    var reSurname = /^[A-Z][a-z]{3,20}$/;
    var reMail = /^[A-z][\w.]{1,}\@[a-z][\w]{1,}(\.)+[a-z.]{1,}$/;
    var rePasswd = /^[0-9A-z\!\#\$\%\^\&\*\/]{7,20}$/;
    var rehomeaddr = /^[A-Z][A-Za-z0-9\s\-\/]{5,45}$/;
    var rezip = /^[0-9\-\sA-z]{3,12}$/;
    var rephnumber = /^\+[0-9]{8,18}$/;
    var repaynumber = /^[0-9]{15,19}$/;
    var recsc = /^[0-9]{3,5}$/;
    document.getElementById("firstname").addEventListener("blur",function(){
        var fname = $("#firstname").val();
        if(!reName.test(fname)){
            document.getElementById("firstname").style.border = "1px solid red";
        }
        else {
            document.getElementById("firstname").style.border = "1px solid #555";
        }
    });
    document.getElementById("lastname").addEventListener("blur",function(){
        var lname = $("#lastname").val();
        if(!reSurname.test(lname)){
            document.getElementById("lastname").style.border = "1px solid red";
        }
        else {
            document.getElementById("lastname").style.border = "1px solid #555";
        }
    });
    document.getElementById("email").addEventListener("blur",function(){
        var mail = $("#email").val();
        if(!reMail.test(mail)){
            document.getElementById("email").style.border = "1px solid red";
        }
        else {
            document.getElementById("email").style.border = "1px solid #555";
        }
    });
    document.getElementById("homeaddress").addEventListener("blur",function(){
        var homeaddr = $("#homeaddress").val();
        if(!rehomeaddr.test(homeaddr)){
            document.getElementById("homeaddress").style.border = "1px solid red";
        }
        else {
            document.getElementById("homeaddress").style.border = "1px solid #555";
        }
    });
    document.getElementById("zipcode").addEventListener("blur",function(){
        var zip = $("#zipcode").val();
        if(!rezip.test(zip)){
            document.getElementById("zipcode").style.border = "1px solid red";
        }
        else {
            document.getElementById("zipcode").style.border = "1px solid #555";
        }
    });
    document.getElementById("phonenumber").addEventListener("blur",function(){
        var phnumber = $("#phonenumber").val();
        if(!rephnumber.test(phnumber)){
            document.getElementById("phonenumber").style.border = "1px solid red";
        }
        else {
            document.getElementById("phonenumber").style.border = "1px solid #555";
        }
    });
    document.getElementById("paymentcardnumber").addEventListener("blur",function(){
        var paycard = $("#paymentcardnumber").val();
        if(!repaynumber.test(paycard)){
            document.getElementById("paymentcardnumber").style.border = "1px solid red";
        }
        else {
            document.getElementById("paymentcardnumber").style.border = "1px solid #555";
        }
    });
    document.getElementById("csc").addEventListener("blur",function(){
        var csc = $("#csc").val();
        if(!recsc.test(csc)){
            document.getElementById("csc").style.border = "1px solid red";
        }
        else {
            document.getElementById("csc").style.border = "1px solid #555";
        }
    });
    document.getElementById("password").addEventListener("blur",function(){
        var password = $("#password").val();
        if(!rePasswd.test(password)){
            document.getElementById("password").style.border = "1px solid red";
        }
        else {
            document.getElementById("password").style.border = "1px solid #555";
        }
    });
    document.getElementById("confirmpassword").addEventListener("blur",function(){
        var confirmpassword = $("#confirmpassword").val();
        if($("#password").val()!=confirmpassword){
            document.getElementById("confirmpassword").style.border = "1px solid red";
            document.getElementById("password").style.border = "1px solid red";
        }
        else {
            document.getElementById("confirmpassword").style.border = "1px solid #555";
            document.getElementById("password").style.border = "1px solid #555";
        }
    });
    $("#createaccbtn").click(function(e){
        e.preventDefault();
        var country = document.getElementById("country");
        var countrylistSelected = country.options[country.selectedIndex].value;
        var daylist = document.getElementById("daylist");
        var daylistSelected = daylist.options[daylist.selectedIndex].value;
        var monthlist = document.getElementById("monthlist");
        var monthlistSelected = monthlist.options[monthlist.selectedIndex].value;
        var yearlist = document.getElementById("yearlist");
        var yearlistSelected = yearlist.options[yearlist.selectedIndex].value;
        var fname = $("#firstname").val();
        var lname = $("#lastname").val();
        var mail = $("#email").val();
        var homeaddr = $("#homeaddress").val();
        var zip = $("#zipcode").val();
        var phnumber = $("#phonenumber").val();
        var paycard = $("#paymentcardnumber").val();
        var csc = $("#csc").val();
        var password = $("#password").val();
        var confirmpassword = $("#confirmpassword").val();
        var arrayofincorrectness = [];
        if(!reName.test(fname)){
            arrayofincorrectness.push("Wrong first name format");
        }
        if(!reSurname.test(lname)){
            arrayofincorrectness.push("Wrong last name format");
        }
        if(!reMail.test(mail)){
            arrayofincorrectness.push("Wrong email format");
        }
        if(!rePasswd.test(password) || !rePasswd.test(confirmpassword) && (password===confirmpassword)){
            arrayofincorrectness.push("Wrong password format");
        }
        if(!rehomeaddr.test(homeaddr)){
            arrayofincorrectness.push("Wrong home address format");
        }
        if(!rezip.test(zip)){
            arrayofincorrectness.push("Wrong zip code format");
        }
        if(!rephnumber.test(phnumber)){
            arrayofincorrectness.push("Wrong phone number format");
        }
        if(!repaynumber.test(paycard)){
            arrayofincorrectness.push("Wrong payment card format");
        }
        if(!countrylistSelected || !daylistSelected || !monthlistSelected || !yearlistSelected){
            arrayofincorrectness.push("You have to choose a date of birth and a country");
        }
        if(!recsc.test(csc)){
            arrayofincorrectness.push("Wrong csc format");
        }
        if(!arrayofincorrectness.length){
            $.ajax({
                url: "api/user/register",
                type : "POST",
                data : {
                    firstName : fname,
                    lastName : lname,
                    email : mail,
                    homeAddress : homeaddr,
                    zip : zip,
                    phoneNumber : phnumber,
                    paymentCard : paycard,
                    csc : csc,
                    password : password,
                    country : countrylistSelected,
                    day : daylistSelected,
                    month : monthlistSelected,
                    year : yearlistSelected
                },
                success : function(data,xhr){
                        $(".register").html("<h3 align='center'>Registration successfully completed. Log in to your e-mail account and check emails to confirm your account.</h3>");
                        console.log(data);
                },
                error: function(xhr,statusTxt,error){
                    switch(xhr.status){
                        case 500:
                            alert(xhr.responseText);
                            break;
                        case 422:
                            alert("Data is not correct");
                            break;
                    }
                }
            });
        }
        else{
            alert("Incorrect data");
        }
    });
});