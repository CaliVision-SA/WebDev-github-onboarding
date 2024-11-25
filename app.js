// Selectors
const userForm = document.getElementById('userForm');
const userList = document.getElementById('userList');

// Load users from localStorage on page load
document.addEventListener('DOMContentLoaded', loadUsers);

// Handle form submission
userForm.addEventListener('submit', function(event) {
    event.preventDefault();

    // Get form values
    const name = document.getElementById('name').value;
    const email = document.getElementById('email').value;
    const phone = document.getElementById('phone').value;
    const gender = document.getElementById('gender').value;
    const weight = document.getElementById('weight').value;
    const height = document.getElementById('height').value;
    const goal = document.getElementById('goal').value;

    // Validate required fields
    if (!name || !email || !height) {
        alert('Please fill out all required fields (Name, Email, Height).');
        return;
    }

    // Create user object
    const user = { name, email, phone, gender, weight, height, goal };

    // Save to localStorage
    saveUser(user);

    // Add user to the list dynamically
    addUserToList(user);

    // Clear the form
    userForm.reset();
});

// Save user to localStorage
function saveUser(user) {
    const users = JSON.parse(localStorage.getItem('users')) || [];
    users.push(user);
    localStorage.setItem('users', JSON.stringify(users));
}

// Add user to the list (DOM)
function addUserToList(user) {
    const li = document.createElement('li');
    li.textContent = `${user.name} (${user.email}, ${user.phone || 'N/A'}) - 
                      ${user.gender}, ${user.weight}, ${user.height} cm - 
                      Goal: ${user.goal}`;
    userList.appendChild(li);
}

// Load users from localStorage
function loadUsers() {
    const users = JSON.parse(localStorage.getItem('users')) || [];
    users.forEach(addUserToList);
}
