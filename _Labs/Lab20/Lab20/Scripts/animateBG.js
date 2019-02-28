function setMood() {
    var mood = $("#MoodBox option:selected").text();
    alert(mood);
    var color;
    if (mood === "Angry") {
        color = "#FF0099";
    } else if (mood === "Sad") {
        color = "blue";
    }
    else if (mood === "Happy") {
        color = "yellow";
    }
    $("#MoodBG").css("background-color", color);
    $("#MoodBG").css("opacity", "0");
    $("#MoodBG").animate
        ({ opacity: 1 });
}
