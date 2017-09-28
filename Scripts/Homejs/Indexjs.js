
function main(option) {
    var questionselector = option.selector.questionContainer;
    var questionId = option.selector.hiddenQuestionId;
    var questionUrl = option.url.questionUrl;
    $(questionselector).click(function () {
        window.location.href = questionUrl + "?questionId=" + $(this).find(".hidden-value-questionId").val();
    });
}