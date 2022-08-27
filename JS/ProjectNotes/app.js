console.log("Welcome To Notes App")
displayNotes();

let addBtn = document.getElementById('addBtn');

addBtn.addEventListener("click", function (e) {

    let addTxt = document.getElementById('addTxt');
    let notes = localStorage.getItem("notes");
 
    if (notes == null)
        notesObj = [];
    else
        notesObj = JSON.parse(notes);

    notesObj.push(addTxt.value)
    localStorage.setItem("notes", JSON.stringify(notesObj));
    addTxt.value = "";
    displayNotes();
})


function displayNotes() {
    let notes = localStorage.getItem("notes");
    if (notes == null)
        notesObj = [];
    else
        notesObj = JSON.parse(notes);
        
    let htmlString = "";
    notesObj.forEach(function (element, index) {
        htmlString += ` <div class=" noteCard my-2 mx-2 card" style="width: 18rem;">
        
            <h5 class="card-title">Note ${index + 1}</h5>
            <p class="card-text">${element}</p>
            <button class="btn btn-danger" id="${index}" onclick="deleteNotes(this.id)">Delete Note</a>
        </div>
    </div>`

    });

    let notesElem = document.getElementById("notes");
    if (notesObj.length != 0)
        notesElem.innerHTML = htmlString;
    else
        notesElem.innerHTML = `Nothing to Disaplay`;
}

//Function to Disaplay Notes
function deleteNotes(index) {
    let notes = localStorage.getItem("notes");
    if (notes == null) 
        notesObj = [];
    else 
        notesObj = JSON.parse(notes);
        
    notesObj.splice(index, 1);
    localStorage.setItem("notes", JSON.stringify(notesObj));
    displayNotes();
}

let searchNote = document.getElementById("searchInput");
searchNote.addEventListener("input", function () {
    let inputValue = searchNote.value.toLowerCase();
    let noteCatrds = document.getElementsByClassName("noteCard");
    Array.from(noteCatrds).forEach(function (element) {
        let cardText = element.getElementsByTagName("p")[0].innerText;
        
        if (cardText.includes(inputValue)) 
            element.style.display = "block";
        else
            element.style.display = "none";
    })
})
