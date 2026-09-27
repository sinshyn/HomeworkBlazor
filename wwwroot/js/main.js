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


// show modal nap-rut tien
window.showTransactionModal = () => {
    const modalEl = document.getElementById("transactionModal");
    const modal = bootstrap.Modal.getOrCreateInstance(modalEl);
    modal.show();
};

//ẩn modaltransaction
window.hideTransactionModal = () => {
    const modalEl = document.getElementById('transactionModal'); // đổi đúng id modal của bạn
    const modal = bootstrap.Modal.getInstance(modalEl);
    modal?.hide();
};