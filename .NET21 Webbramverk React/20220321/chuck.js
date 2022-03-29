const button = document.querySelector("#btnGetAPI");
const display = document.querySelector("#displayAPI");

button.addEventListener("click", getApiData);

async function getApiData(e) {
    let fetched = await fetch("https://api.chucknorris.io/jokes/random");
    let data = await fetched.json(fetched);

    let image = document.createElement("img");
    image.setAttribute("src", data.icon_url)

    display.innerHTML=data.value + "<br>";
    display.appendChild(image);
}