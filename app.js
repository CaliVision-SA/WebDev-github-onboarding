document.addEventListener('DOMContentLoaded', () => {
    const userForm = document.getElementById('userForm');
    const userList = document.getElementById('userList');
    const errorModal = document.getElementById('errorModal');
    const closeModal = document.getElementById('closeModal');
  

    loadUsers();

    userForm.addEventListener('submit', (e) => {
      e.preventDefault();
  
      const username = document.getElementById('username').value.trim();
      const description = document.getElementById('description').value.trim();
  
      if (username && description) {
        addUser(username, description);
        userForm.reset();
      } else {
        showModal();
      }
    });

    function showModal() {
      errorModal.classList.remove('hidden');
    }
  

    closeModal.addEventListener('click', () => {
      errorModal.classList.add('hidden');
    });
  
 
    errorModal.addEventListener('click', (e) => {
      if (e.target === errorModal) {
        errorModal.classList.add('hidden');
      }
    });
  

    function addUser(username, description) {
      const users = getUsersFromStorage();
      users.push({ username, description });
      localStorage.setItem('users', JSON.stringify(users));
      displayUsers();
    }
  
    /// Get users from localStorage web API
    function getUsersFromStorage() {
      const users = localStorage.getItem('users');
      return users ? JSON.parse(users) : [];
    }
  

    function displayUsers() {
      const users = getUsersFromStorage();
      userList.innerHTML = '';
      users.forEach((user) => {
        const li = document.createElement('li');
        li.className =
          'p-4 bg-gray-100 rounded-md shadow-md flex justify-between items-center';
        li.textContent = `${user.username} - ${user.description}`;
        userList.appendChild(li);
      });
    }
  

    function loadUsers() {
      displayUsers();
    }
  });
  