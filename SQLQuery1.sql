

  CREATE TABLE  userss
(
  id INT PRIMARY KEY IDENTITY (1,1),
  username VARCHAR (MAX) NULL,
  password VARCHAR (MAX) NULL,
  role VARCHAR(MAX) NULL,
  status VARCHAR(MAX) NULL,
  date_register DATE NULL
  )

  SELECT * FROM userss
  INSERT INTO userss(username,password,role,status,date_register) VALUES('admin','admin123','Admin','Active','2025-06-03')
   UPDATE userss SET date_register = '2025-06-09' WHERE id = 2
   


   

    
 

  

  