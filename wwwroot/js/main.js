// bắt lỗi focus
window.focusElement = (id) => {
  const el = document.getElementById(id);
  if (el) {
    el.focus();
    el.scrollIntoView({ behavior: "smooth", block: "center" });
  }
};

// display modal car
window.showCarModal = () => {
    const modalEl = document.getElementById("modalId");
    const modal = bootstrap.Modal.getOrCreateInstance(modalEl);
    modal.show();
};