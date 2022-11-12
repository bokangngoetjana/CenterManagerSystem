
$(function () {

    $('.datepicker').datepicker(
        {
            dateFormat: 'yy-mm-dd',
            minDate: new Date(),
            maxDate: AddSubtractMonths(new Date(), 6)
        }
    );

    function AddSubtractMonths(date, numMonths) {
        var month = date.getMonth();
        var milliSeconds = new Date(date).setMonth(month + numMonths);

        return new Date(milliSeconds);
    }

});
