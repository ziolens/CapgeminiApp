jQuery("document").ready(function () {
    jQuery("#updateButton, #removeButton").hide();
    jQuery("#select").change(function () {
        jQuery("#updateButton, #removeButton").show();
        var id = jQuery("#select option:selected").val();
        var hrefUpdate = "/Customer/Update/" + id;
        jQuery("#updateButton").prop("href", hrefUpdate);
        var hrefRemove = "/Customer/Remove/" + id;
        jQuery("#removeButton").prop("href", hrefRemove);
    });
});