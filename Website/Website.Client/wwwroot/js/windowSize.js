// listen for page resize
function resizeListener(dotnethelper) {
    $(window).resize(() => {
        let browserHeight = $(window).innerHeight();
        let browserWidth = $(window).innerWidth();

        dotnethelper.invokeMethodAsync('SetBrowserDimensions', browserWidth, browserHeight).then(() => {
            return browserWidth;
        }).catch(error => {
            console.log("Error during browser resize: " + error);
        });
    });
}

window.getDimensions = function () {
    return {
        width: window.innerWidth,
        height: window.innerHeight
    };
};