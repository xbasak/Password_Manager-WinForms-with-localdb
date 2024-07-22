<h1> Hi there! :) I've created an application that allows you to safely store your passwords locally on your computer. </h1>

At the very start, the user must create a local account, which is protected by a password, only to be able to store passwords for other accounts. When the account is created, a 32 byte AES-256 encryption key is generated. This key is then encrypted, where the key to encrypt the generated key this time becomes the user's password. The encrypted key is located in the /AppData/Roaming/PasswordManager/ directory. Each time the program is used, the key is decrypted with the user's password, which only the user knows, and the data is validated at login.
The user can then add passwords to accounts, edit, delete or arrange them in any order. This data, too, is encrypted with a key that was generated when the local account was set up, and decrypted only when the program is used.
All this data is stored in a local SQLite database. 

Enjoy it!

![login_form](https://github.com/user-attachments/assets/1adb3ca3-12e7-4ad1-aef2-de57ed1777a3)
![main_form1](https://github.com/user-attachments/assets/09145f81-c12d-4a74-aa95-64d9a4dbbe14)
![main_form2](https://github.com/user-attachments/assets/7eaff606-a588-4475-bd90-dd7cd5791fd6)
![main_form4](https://github.com/user-attachments/assets/0be7475c-2dc8-4990-b77a-dcbd10f8156c)
![main_form3](https://github.com/user-attachments/assets/0063ccb0-c5c2-45dd-b1d8-03f101b4cbb7)
