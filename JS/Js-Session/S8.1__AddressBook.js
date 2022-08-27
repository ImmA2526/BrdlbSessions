// Start with Displaying Welcome to Address Book Program in AddressBookMain class on
// START Master Branch

console.log('Welcome to Address Book Program');
let users = [
  [
    'Amir',
    'Khan',
    '9988778899',
    'Pune',
    'MH',
    '411033',
    'amir121123@gmail.com',
  ],
  [
    'Akshay',
    'Kumar',
    '8899000099',
    'Agra',
    'UP',
    '282001',
    'akshay123@gmail.com',
  ],
  [
    'Rishi',
    'Kapoor',
    '8877778899',
    'Mathura',
    'UP',
    '411033',
    'kumari412@gmail.com',
  ],
  [
    'Swati',
    'Pandey',
    '7013362779',
    'Delhi',
    'Delhi',
    '213569',
    'swati702@gmail.com',
  ],
];
/** UC1: Ability to create a Contacts in AddressBook with first and last names, address,
city, state, zip, phone number and
email */

class AddressBookMain {
  constructor(firstName, lastName, phoneNumber, city, state, zip, email) {
    this.id = Math.random().toString(16).slice(2);
    this.firstName = firstName;
    this.lastName = lastName;
    this.phoneNumber = phoneNumber;
    this.email = email;
    this.address = {
      city,
      state,
      zip,
    };
  }


  addition() {
    console.log("Calling addtion");
  }
}


class worker extends AddressBookMain {
  multip() {
    this.addition()
  }

}
/**UC2: bility to add a new Contact to Address Book*/
//Generating array of Users
const details = users.map((user) => {
  return new AddressBookMain(...user);
});
console.log(details);

/** UC3: Ability to edit existing contact person using their name*/
// Update any user detail
console.log('-----------------------------------------------');
const updatedDetails = details.map((user) => {
  if (user.firstName === 'Akshay') {
    return {
      ...user,
      lastName: 'Kumar',
    };
  }
  return user;
});
console.log(updatedDetails);

/** UC4: Ability to delete a person using person's name */
// Delete User
console.log('-----------------------------------------------');
const finalArr = updatedDetails.filter((user) => user.firstName !== 'Imran');
console.log("" + finalArr);