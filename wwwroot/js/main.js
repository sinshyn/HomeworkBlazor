// bắt lỗi focus
window.focusElement = (id) => {
  const el = document.getElementById(id);
  if (el) {
    el.focus();
    el.scrollIntoView({ behavior: "smooth", block: "center" });
  }
};
