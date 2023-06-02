// Put your code here

//All Place Names
const names = [
   "Nashville", "Hong Kong", "The back yard", "Earth",
    "London", "The mall", "Ryman Auditorium", "The Great Wall of China"
];

console.log("All Place Names");

for (const name of names) {
  console.log(name);

}

//Space to divide the two
console.log("")

//"The" place names
console.log("'The' Place Names")

let filtered = names.filter(name => name.startsWith("The"))
for (const f of filtered){

  console.log(f)
}


