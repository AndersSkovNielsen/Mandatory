//Opgave kode

const gramMultiplier: number = 28.34952;
const ounceMultiplier: number = 0.03527396195;

let weight: HTMLElement = <HTMLElement> document.getElementById("weight");

function toGrams(weight: number): string {
    return weight * gramMultiplier + " grams";
}

function toOunces(weight: number): string {
    return weight * ounceMultiplier + " ounces";
}

let oButton: HTMLButtonElement = <HTMLButtonElement> document.getElementById("OButton");

let gButton: HTMLElement = <HTMLElement> document.getElementById("GButton");

oButton.addEventListener = toOunces(Number(weight));

gButton.addEventListener = toGrams(Number(weight));

let result: HTMLDivElement = <HTMLDivElement> document.getElementById("result");
result.innerHTML = toGrams(Number(weight)) || toOunces(Number(weight));