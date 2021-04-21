function OpenNewTaskForm(event) {
    $("div.task-create").removeClass("hidden");
    $("#create-task-btn").addClass("hidden");
}

function CreateTask(event) {
    var description = $("div.task-create textarea").val();
    $.post("/Task/Create", { description: description });
    $("div.task-create").addClass("hidden");
    $("#create-task-btn").removeClass("hidden");
}

function CancelCreateTask(event) {
    $("div.task-create textarea").val("");
    $("div.task-create").addClass("hidden");
    $("#create-task-btn").removeClass("hidden");
}

function EditTask(event, taskId) {
    $("#task-" + taskId).addClass("hidden");
    $("#edit-" + taskId).removeClass("hidden");

    var taskDescription = $("#task-" + taskId + " span.task-description").text();
    $("#edit-" + taskId + " textarea").val(taskDescription);
}

function SaveEditTask(event, taskId) {
    var newDescription = $("#edit-" + taskId + " textarea").val();
    $.post("/Task/Edit", { taskId: taskId, description: newDescription });
    $("#task-" + taskId + " span.task-description").text(newDescription);

    $("#task-" + taskId).removeClass("hidden");
    $("#edit-" + taskId).addClass("hidden");
}

function CancelEditTask(event, taskId) {
    $("#task-" + taskId).removeClass("hidden");
    $("#edit-" + taskId).addClass("hidden");
}