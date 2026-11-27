USE studentmanagementsystem;

CREATE TABLE users (
    userId INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    passwordHash VARCHAR(255) NOT NULL,
    role VARCHAR(50) NOT NULL
);

INSERT INTO users (username, passwordHash, role)
VALUES 
	('admin', 'admin1234', 'Admin'),
	('staff', 'staff1234', 'Staff');