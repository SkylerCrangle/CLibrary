

--CREATE TABLE libraries (
--id INT NOT NULL AUTO_INCREMENT,
--name VARCHAR(255) NOT NULL,
--location VARCHAR(255) NOT NULL,
--PRIMARY KEY (id)
--);

--books
--libraries one to many
--authors One to many
--bookauthors many to many

--Books
--Libraries
--Authors
--Book{
--libraryId // one to many
--}
--BookAuthors { // many to many
--bookId:
--authorId:
--}


CREATE TABLE books (
  id INT NOT NULL AUTO_INCREMENT,
  title VARCHAR(255) NOT NULL,
  libraryId INT NOT NULL,
  isAvailable TINYINT,
  PRIMARY KEY (id),

  FOREIGN KEY (libraryId)
    REFERENCES libraries(id)
    ON DELETE CASCADE
);