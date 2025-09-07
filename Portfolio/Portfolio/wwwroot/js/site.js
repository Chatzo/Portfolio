document.addEventListener("DOMContentLoaded", function () {
    const headline = document.querySelector('#typed_headline');
    if (headline) {
        function startTypedSequence() {
            new Typed('#typed_headline', {
                strings: ["<span class='fs-5'>Hi there! I'm</span><span class='fs-3 fw-bold ms-2 shining-text'>Georgios Chatzoglakis</span>"],
                typeSpeed: 25,
                showCursor: false,
                onComplete: function () {
                    new Typed('#typed_description', {
                        strings: ["<p class='fs-5'>I'm a <span class='shining-underline fs-5'>creative developer</span> based in Stockholm!</p><p class='fs-5'>I believe the future lies in mixed reality applications and AI solutions!</p>"],
                        typeSpeed: 25,
                        showCursor: false,
                    });
                }
            });
        }
       
        startTypedSequence();
    }

    //Stop YouTube videos safely on slide change
    const carousel = document.getElementById('mediaCarousel');
    if (carousel) {
        carousel.addEventListener('slide.bs.carousel', function () {
            const iframes = carousel.querySelectorAll('iframe');
            iframes.forEach(function (iframe) {
                if (iframe.src.includes('youtube.com/embed')) {
                    try {
                        if (iframe.contentWindow) {
                            iframe.contentWindow.postMessage('{"event":"command","func":"stopVideo","args":""}', '*');
                        }
                    } catch (e) {
                        console.warn("Could not stop YouTube video:", e);
                    }
                }
            });
        });
    }
   
});