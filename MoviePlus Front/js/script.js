//Log out on click
$('.log-out').on('click', function() {
  window.sessionStorage.accessToken = null;
  window.sessionStorage.actor.id = null;
  window.location.href = '/index.html';
});

function takeFullDate(date){
    let splitDate = date.split("T");

    return splitDate[0] + " " +splitDate[1];
  }


function takeDate(date) {

  let splitDate = date.split("T");

  return splitDate[0];
} 

function takeTime(date) {

  let splitDate = date.split("T");

  return splitDate[1];
}  


