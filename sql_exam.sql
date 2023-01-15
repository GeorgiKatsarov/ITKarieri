### create the database
CREATE TABLE characteristics(
characteristic_id INT PRIMARY KEY AUTO_INCREMENT,
    title NVARCHAR(255) NOT NULL
);

CREATE TABLE users(
user_id INT PRIMARY KEY AUTO_INCREMENT,
    username NVARCHAR(50) NOT NULL,
    email NVARCHAR(255) NOT NULL,
    password NVARCHAR(255) NOT NULL,
    first_name NVARCHAR(255) NOT NULL,
    last_name NVARCHAR(255) NOT NULL,
    birthdate DATE NOT NULL,
    gender ENUM('m', 'f') NOT NULL,
    bio TEXT,
    latitude DOUBLE NOT NULL,
    longitude DOUBLE NOT NULL,
    profile_picture NVARCHAR(50)
);

CREATE TABLE characteristics_users(
characteristic_id INT,
    user_id INT,
    value NVARCHAR(255) NOT NULL,
    PRIMARY KEY (characteristic_id, user_id),
    FOREIGN KEY (characteristic_id) REFERENCES characteristics(characteristic_id),
    FOREIGN KEY (user_id) REFERENCES users(user_id)
);

CREATE TABLE connections(
connection_id INT PRIMARY KEY AUTO_INCREMENT,
from_user_id INT NOT NULL,
    to_user_id INT NOT NULL,
    accepted TINYINT(1) NOT NULL,
    FOREIGN KEY (from_user_id) REFERENCES users(user_id),
    FOREIGN KEY (to_user_id) REFERENCES users(user_id)
);

CREATE TABLE likes(
liked_by_user_id INT,
liked_user_id INT,
    PRIMARY KEY (liked_by_user_id, liked_user_id),
    FOREIGN KEY (liked_by_user_id) REFERENCES users(user_id),
    FOREIGN KEY (liked_user_id) REFERENCES users(user_id)
);
### 1

select title from characteristics order by title limit 5;

### 2
select from_user_id, to_user_id, accepted from connections where from_user_id = 481 and accepted = 1 order by to_user_id desc;
### 3 

SELECT username
FROM users
JOIN (SELECT liked_user_id, COUNT(*) AS likes_count FROM likes GROUP BY liked_user_id) as likes_cte 
ON users.user_id = likes_cte.liked_user_id
ORDER BY likes_count DESC, user_id DESC
LIMIT 3;

### 4

SELECT u.user_id, u.username, u.first_name, u.last_name
FROM users u
LEFT JOIN likes l ON l.liked_user_id = u.user_id
WHERE l.liked_user_id IS NULL
ORDER BY u.first_name ASC, u.last_name ASC
LIMIT 10;

### 5 

SELECT username 
FROM users 
WHERE user_id IN (
    SELECT user_id 
    FROM users 
    WHERE birthdate > '1990-01-01' AND birthdate < '1999-12-31' AND gender = 'f'
) 
AND user_id IN (
    SELECT user_id 
    FROM characteristics_users 
    WHERE value = 'blue'
)
ORDER BY username DESC;

### 6

SELECT ROUND (AVG (cast(value as decimal(10,2))), 2) as average_height
FROM characteristics_users
WHERE characteristic_id = (SELECT characteristic_id FROM characteristics where title = 'Height');

### 7

SELECT liked_by.username as liked_by, liked.username as liked, liked_by_eye_color.value as liked_by_eye_color, liked_eye_color.value as liked_eye_color
FROM likes
JOIN users as liked_by ON liked_by_user_id = liked_by.user_id
JOIN users as liked ON liked_user_id = liked.user_id
JOIN characteristics_users as liked_by_eye_color ON liked_by.user_id = liked_by_eye_color.user_id
JOIN characteristics_users as liked_eye_color ON liked.user_id = liked_eye_color.user_id
WHERE liked_by_eye_color.characteristic_id = (SELECT characteristic_id FROM characteristics WHERE title = 'Eye color')
AND liked_eye_color.characteristic_id = (SELECT characteristic_id FROM characteristics WHERE title = 'Eye color')
ORDER BY liked_by.username, liked.username
LIMIT 5;
