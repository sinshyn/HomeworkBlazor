window.showAlert = (title, text, icon) => {
    Swal.fire({
        title: title,
        text: text,
        icon: icon
    });
};

window.showConfirm = async (title, text) => {
    const result = await Swal.fire({
        title: title,
        text: text,
        icon: 'warning',
        showCancelButton: true,
        confirmButtonText: 'Đồng ý',
        cancelButtonText: 'Hủy'
    });
    return result.isConfirmed;
};


