let booksData = [];

// Get all Books => /api/books
exports.getAllBooks = (req, res) => {
const data = { 
    message: "Sucessfull", 
    result: booksData,
    count: booksData.length 
};
console.log(data);
  res.status(200).json(data);
};

// Create a Book => /api/create-book
exports.createBook = (req, res) => {
  const uniqueId = Math.random().toString(16).slice(2);
  const newBook = {
      ...req.body,
      id: uniqueId
  };
console.log(newBook);
  booksData.push(newBook);
  res
    .status(200)
    .json({ message: "Sucessfully created the book", result: newBook });
};

// Create a Book => /api/book/id
exports.updateBook = (req, res) => {
let bookId = req.params.id;
// find the book
// if book is available in store, update it
// else throw and error message.
// update the book in book store
let book = booksData.find(item => item.id === bookId);

if(!book) {
  return res
    .status(404)
    .json({ message: "Book Not found" });
    
}
let updatedBook = {
  ...book, 
  ...req.body 
};
console.log(updatedBook);
booksData = booksData.map((el) => el.id === bookId ? updatedBook: el);

 return res
    .status(200)
    .json({ message: "Sucessfully updated the book." , result: updatedBook});

};


exports.deleteBook = (req, res) => {
  let bookId = req.params.id;
  let book = booksData.find(item => item.id === bookId);
  if(!book) {
   return res
      .status(404)
      .json({ message: "Book Not found" });
  }
  booksData = booksData.filter(item => item.id !== bookId);
  return res
    .status(200)
    .json({ message: "Sucessfully Deleted the book." , result: book});
  // check the book , its there or not in bookstore
  // delete the book
  // update the storebook

}




// let booksData = [];

// // Get all Books => /api/books
// exports.getAllBooks = (req, res) => {
//   res.status(200).json({ message: "Sucessfull", result: booksData });
// };

// // Create a Book => /api/create-book
// exports.createBook = (req, res) => {
//   const uniqueId = Math.random().toString(16).slice(2);
//   const newBook = {
//       ...req.body,
//       id: uniqueId
//   };

//   booksData.push(newBook);
//   res
//     .status(200)
//     .json({ message: "Sucessfully created the book", result: newBook });
// };