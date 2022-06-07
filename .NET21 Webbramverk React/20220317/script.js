function AddToList(str) {
    let newObj = document.createElement("li");
    newObj.textContent = "Ny!";
    document.querySelector("#listFan").appendChild(newObj);
}

function RemoveFromList() {
    let remObj = document.querySelector("#listFan").lastChild;
    remObj.remove();
}

document.querySelector("#add")
.addEventListener("click", e => AddToList(e));