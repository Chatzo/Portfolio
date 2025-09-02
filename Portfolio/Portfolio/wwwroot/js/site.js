document.addEventListener("DOMContentLoaded", function () {
    const headline = document.querySelector('#typed_headline');
    if (headline) {
        function startTypedSequence() {
            new Typed('#typed_headline', {
                strings: ["<span class='fs-5'>Hi there! I'm</span><span class='fs-3 fw-bold ms-2 shining-text'>Georgios Chatzoglakis</span>"],
                typeSpeed: 35,
                showCursor: false,
                onComplete: function () {
                    new Typed('#typed_description', {
                        strings: ["<p class='fs-5'>I'm a <span class='shining-underline fs-5'>creative developer</span> based in Stockholm!</p><p class='fs-5'>I believe the future lies in mixed reality applications and AI solutions!</p>"],
                        typeSpeed: 35,
                        showCursor: false,
                    });
                }
            });
        }
       
        startTypedSequence();
    }
   
});