// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.




const toTop = (() => {
        let button = document.getElementById("toTop");
  window.onscroll = () => {
        button.classList[
            (document.documentElement.scrollTop > 200) ? "add" : "remove"
        ]("is-visible")
    }
  button.onclick = () => {
        window.scrollTo({
            top: 0, behavior: "smooth"
        })
    }
})();