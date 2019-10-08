var studenten;
window.onload = uitlezen;


function inschrijven(){
    var student = {};
    student.firstname = document.getElementById("fvoornaam").value;
    student.lastname = document.getElementById("fachternaam").value;
    student.birthdate = document.getElementById("fgebdatum").value;
    //check welke radios gecheckt is
    var radios = document.getElementsByName("programmeertaal");
    for (var i=0; i < radios.length; i++) {
        if (radios[i].checked) {
            student.programmeertaal = radios[i].value;
       }
    }
    studenten.push(student);
    var studentenJson = JSON.stringify(studenten);
    localStorage.setItem("mijnstudenten", studentenJson);
    
}
function uitlezen(){
    var opTeHalen = localStorage.getItem("mijnstudenten");
    //console.log(opTeHalen);
    var opgehaaldObject = JSON.parse(opTeHalen);
    console.log(opgehaaldObject);
    studenten = opgehaaldObject;

    return studenten;
}
function starten(){
    studenten = [];
}

function anderePaginaKlik() {
    var onzeList = document.getElementById("resultaatList");
    var studenten = uitlezen();
    for (i=0; i<studenten.length; i++) {
        node=document.createElement("LI");
        textnode=document.createTextNode("Voornaam: "+studenten[i].firstname+", Achternaam: "+studenten[i].lastname+", Geboortedatum: "+studenten[i].birthdate+", Programmeertaal: "+studenten[i].programmeertaal)
        node.appendChild(textnode);
        onzeList.appendChild(node);

        if (studenten[i].programmeertaal == "Python" ) {
            node.classList.add("green")
        }

        if (studenten[i].programmeertaal == "Java") {
            node.classList.add("blue")
        }

        if (studenten[i].programmeertaal == "C#") {
            node.classList.add("red")
        }

    }
}

function studentenClear() {
    studenten = [];
    var studentenJson = JSON.stringify(studenten);
    localStorage.setItem("mijnstudenten", studentenJson);

}