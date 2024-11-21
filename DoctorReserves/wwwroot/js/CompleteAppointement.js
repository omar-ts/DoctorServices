let completed_page = document.querySelector(".completed_page_not");
function completed() {
    completed_page.classList.remove("completed_page_not");
    completed_page.classList.add("completed_page");
}
function notcompleted() {
    completed_page.classList.remove("completed_page");
    completed_page.classList.add("completed_page_not");
}
