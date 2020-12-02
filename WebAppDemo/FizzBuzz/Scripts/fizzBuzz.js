const FizzBuzz = (function () {

    const bindEvent = function () {

        let btnClear = $("#btnClear");
        let btnSubmit = $("#btnSubmit");

        btnClear.off("click").on("click", function () {
            $("#textbox").val("");
            _clearResult();
            _clearErrorMessage();
        });

        btnSubmit.off("click").on("click", function () {

            _clearResult();
            _clearErrorMessage();

            let input = $("#textbox").val();
            
            FizzBuzz.Submit(input);
        });

    };
    
    const submit = function (data) {
        
        //side note: if url length is larger than 2048, we would use POST and put param in the body but for the demo, we will assume GET would suffice.

        let baseUrl = config.isProd ? `${config.prod.baseUrl}` : config.local.baseUrl + ":" + location.port;

        let settings = {
            method: "GET",
            dataType: "JSON",
            url: `${baseUrl}/api/FizzBuzz/GetFizzBuzz?` + $.param({ input: data }),
            success: function (data) {
                _printResult(data);
            },
            error: function (xhr, textStatus, errorThrown) {
                _displayError(xhr);
            },

        };

        $.ajax(settings);
    };

    const _displayError = function (xhr) {
        
        $("#errorMessage").append(xhr.responseJSON.ExceptionMessage);
    };

    const _clearErrorMessage = function () {

        $("#errorMessage").empty();
    }

    const _clearResult = function () {

        let context = $("#container").find(".result-container");
        context.empty();
    };

    const _printResult = function (resultList) {

        let context = $("#container").find(".result-container");

        for (let i = 0; i < resultList.length; i++) {
            let line = resultList[i];

            context.append(`<div>${line}</div>`);
        }

    };

    return {
        BindEvent: bindEvent,
        Submit: submit,
    };

})();