document.addEventListener("DOMContentLoaded", function () {
    const headline = document.querySelector('#typed_headline');
    if (headline) {
        function startTypedSequence() {
            new Typed('#typed_headline', {
                strings: ["<span class='fs-6'>Hi there! I'm</span><span class='fs-3 fw-bold ms-2 shining-text'>Georgios Chatzoglakis</span>"],
                typeSpeed: 35,
                showCursor: false,
                onComplete: function () {
                    new Typed('#typed_description', {
                        strings: ["<p>I'm a <span class='shining-underline'>developer</span> based in Stockholm!</p>"],
                        typeSpeed: 35,
                        showCursor: false,

                        onComplete: function () {
                            setTimeout(() => {
                                document.getElementById('typed_headline').innerHTML = '';
                                document.getElementById('typed_description').innerHTML = '';
                                startTypedSequence();
                            }, 2000);
                        }
                    });
                }
            });
        }

        startTypedSequence();
    }
});