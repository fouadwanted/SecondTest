document.addEventListener("DOMContentLoaded", function () {
    loadFlightList();
    document.getElementById("flightForm").addEventListener("submit", submitFlightForm);
});

function loadFlightList() {
    fetch("/api/Flights")
        .then(response => response.json())
        .then(flights => {
            const flightListBody = document.getElementById("flightListBody");
            flightListBody.innerHTML = "";
            flights.forEach(flight => {
                const row = document.createElement("tr");
                row.innerHTML = `
                    <td>${flight.name}</td>
                    <td>${flight.idDepartureAirport}</td>
                    <td>${flight.idDepartureAirport}</td>
                `;
                flightListBody.appendChild(row);
            });
        });
}

function submitFlightForm(event) {
    event.preventDefault();
    const name = document.getElementById("name").value;
    const idDepartureAirport = document.getElementById("departureAirport").value;
    const idArrivalAirport = document.getElementById("arrivalAirport").value;

    const flight = {
        name: name,
        idDepartureAirport: idDepartureAirport,
        idArrivalAirport: idArrivalAirport
    };

    fetch("/api/add", {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(flight)
    })
        .then(() => {
            loadFlightList();
            document.getElementById("flightForm").reset();
        });
}
