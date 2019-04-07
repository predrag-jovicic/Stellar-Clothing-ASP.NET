$(".parent").on("click", function (e) {
    e.preventDefault();
    $(".children").stop(true, true);
    $(".children").fadeOut(5);
    $(this).siblings(".children").css({ width: "0", height: "0" });
    $(this).siblings(".children").show();
    $(this).siblings(".children").animate({ width: "+=55", height: "+=145" }, 1300);
});
$(".sb-search-submit").click(function(e){
    if(!$(".sb-search-input").val())
        e.preventDefault();
    $(".sb-search-input").fadeIn("fast");
 });