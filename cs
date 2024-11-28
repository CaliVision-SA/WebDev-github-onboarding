/* General Styles */
body {
    font-family: Arial, sans-serif;
    margin: 0;
    padding: 0;
    line-height: 3;
    color: #000000;
    background-size: cover;
    background-position: center;
    background-attachment: fixed;
    background-repeat: no-repeat;
}

/* Transparent overlay */
body::before {
    content: "";
    position: fixed;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    background: rgba(207, 236, 159, 0.2);
    z-index: -1;
}

/* Header */
header {
    background: #032b21;
    color: #fff;
    padding: 20px 0;
    text-align: center;
    font-size: 1.5rem;
    letter-spacing: 1px;
}

/* Form Section */
form {
    background: rgba(255, 255, 255, 0.9);
    margin: 30px auto;
    padding: 25px;
    max-width: 400px;
    border-radius: 8px;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.15);
}

form div {
    margin-bottom: 20px;
}

label {
    display: block;
    margin-bottom: 8px;
    font-weight: bold;
}

input,
select,
button {
    width: 100%;
    padding: 12px;
    margin-top: 5px;
    border: 1px solid #ccc;
    border-radius: 5px;
    font-size: 1rem;
}

button {
    background: #333;
    color: #fff;
    border: none;
    cursor: pointer;
    transition: background 0.3s;
}

button:hover {
    background: #555;
}

/* User List Section */
ul {
    list-style: none;
    padding: 0;
    margin: 30px auto;
    max-width: 600px;
}

ul li {
    background: rgba(255, 255, 255, 0.9);
    /* Slight transparency for list items */
    margin: 15px 0;
    padding: 20px;
    border-radius: 8px;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
    font-size: 1rem;
}

/* Responsive Design */
@media (max-width: 768px) {
    form {
        max-width: 90%;
        padding: 20px;
    }

    ul {
        max-width: 90%;
    }

    header {
        font-size: 1.3rem;
        padding: 15px 0;
    }
=======
/* General Styles */
body {
    font-family: Arial, sans-serif;
    margin: 0;
    padding: 0;
    line-height: 3;
    color: #000000;
    background-size: cover;
    background-position: center;
    background-attachment: fixed;
    background-repeat: no-repeat;
}

/* Transparent overlay */
body::before {
    content: "";
    position: fixed;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    background: rgba(207, 236, 159, 0.2);
    z-index: -1;
}

/* Header */
header {
    background: #032b21;
    color: #fff;
    padding: 20px 0;
    text-align: center;
    font-size: 1.5rem;
    letter-spacing: 1px;
}

/* Form Section */
form {
    background: rgba(255, 255, 255, 0.9);
    margin: 30px auto;
    padding: 25px;
    max-width: 400px;
    border-radius: 8px;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.15);
}

form div {
    margin-bottom: 20px;
}

label {
    display: block;
    margin-bottom: 8px;
    font-weight: bold;
}

input,
select,
button {
    width: 100%;
    padding: 12px;
    margin-top: 5px;
    border: 1px solid #ccc;
    border-radius: 5px;
    font-size: 1rem;
}

button {
    background: #333;
    color: #fff;
    border: none;
    cursor: pointer;
    transition: background 0.3s;
}

button:hover {
    background: #555;
}

/* User List Section */
ul {
    list-style: none;
    padding: 0;
    margin: 30px auto;
    max-width: 600px;
}

ul li {
    background: rgba(255, 255, 255, 0.9);
    /* Slight transparency for list items */
    margin: 15px 0;
    padding: 20px;
    border-radius: 8px;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
    font-size: 1rem;
}

/* Responsive Design */
@media (max-width: 768px) {
    form {
        max-width: 90%;
        padding: 20px;
    }

    ul {
        max-width: 90%;
    }

    header {
        font-size: 1.3rem;
        padding: 15px 0;
    }

}