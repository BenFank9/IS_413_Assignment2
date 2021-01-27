/*function updateRangeInput(elem) {
    $(elem).next().val($(elem).val());
}
 this would allow for a range slider to have a number on it*/

$("#submit").click(function () {

    /*get all of the inputs from the form and store them to variables*/

    var iAssignmentScore = parseInt($("#assignmentsPercent").val());
    var iGroupProjectScore = parseInt($("#GroupProjectPercent").val());
    var iQuizzesScore = parseInt($("#QuizzesPercent").val());
    var iExamsScore = parseInt($("#ExamsPercent").val());
    var iIntexScore = parseInt($("#IntexPercent").val());
    var iFinalGrade = 0;
    var iLetterGrade = '';

    //calculate the final grade percent and letter

    iFinalGrade = iAssignmentScore + iGroupProjectScore + iQuizzesScore + iExamsScore + iIntexScore;

    if (iFinalGrade >= 94) {
        iLetterGrade = "A"
    }
    else if (iFinalGrade >= 90) {
        iLetterGrade = "A-"
    }
    else if (iFinalGrade >= 87) {
        iLetterGrade = "B+"
    }
    else if (iFinalGrade >= 84) {
        iLetterGrade = "B"
    }
    else if (iFinalGrade >= 80) {
        iLetterGrade = "B-"
    }
    else if (iFinalGrade >= 77) {
        iLetterGrade = "C+"
    }
    else if (iFinalGrade >= 74) {
        iLetterGrade = "C"
    }
    else if (iFinalGrade >= 70) {
        iLetterGrade = "C-"
    }
    else if (iFinalGrade >= 67) {
        iLetterGrade = "D+"
    }
    else if (iFinalGrade >= 64) {
        iLetterGrade = "D"
    }
    else if (iFinalGrade >= 60) {
        iLetterGrade = "D-"
    }
    else {
        iLetterGrade = "E"
    }

    iFinalGrade = String(iFinalGrade);
    //output the calculated grades into the p tag id=output
    var output = "Final Percent Grade: " + iFinalGrade + "% " + "Final Letter Grade: " + iLetterGrade;
    alert(output);
    
});