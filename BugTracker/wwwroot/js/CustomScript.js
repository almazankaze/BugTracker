function confirmDelete(uniqueId, isDeleteClicked) {
    var deleteSpan = 'deleteSpan_' + uniqueId;
    var confirmDeleteSpan = 'confirmDeleteSpan_' + uniqueId;
    var profileSpan = 'profileSpan_' + uniqueId;

    if (isDeleteClicked) {
        $('#' + deleteSpan).hide();
        $('#' + profileSpan).hide();
        $('#' + confirmDeleteSpan).show();
        
    } else {
        $('#' + deleteSpan).show();
        $('#' + profileSpan).show();
        $('#' + confirmDeleteSpan).hide();
    }
}