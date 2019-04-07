var prewidth;
$(".gallery-grid").hover(function(){
    prewidth = $(this).find(".gallery-info").css("top");
    console.log(prewidth);
    $(this).find(".gallery-info").css("top",0);
},function(){
    $(this).find(".gallery-info").css("top",prewidth);
});
function nestajanjePopUp(){
localStorage.setItem("accepted", "true");
//Animacija by Predrag Jovicic
$(".closeButton").fadeOut(600);
$("#popuphead").fadeOut(600);  
$("#popup input").fadeOut(300);
$("#popup").animate({width:"0rem",opacity:"0"},1000);
setTimeout(function(){$("#popup").hide();},1500);
}
$(".closeButton").click(nestajanjePopUp);
$("#okdugme").click(nestajanjePopUp);
$(document).ready(function(){
if (localStorage.getItem("accepted") === null) {
   $("#popup").slideDown();
   localStorage.setItem("accepted",true);
}
});