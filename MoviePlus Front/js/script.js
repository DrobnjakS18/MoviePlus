//Log out on click
$('.log-out').on('click', function() {
  window.sessionStorage.accessToken = null;
  window.sessionStorage.actor.id = null;
  window.location.href = '/index.html';
});