var searchName = null;

callApi();

function callApi() {

  let perPage = $("#perPage").val();
  
  let queryString = `ItemsPerPage=${perPage}`

  if(searchName != null) {
    queryString += `&name=${searchName}`
  }

  $.ajax({
  url : `http://localhost:5101/api/role?${queryString}`,
  headers: {
    'Authorization' : 'Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJqdGkiOiI2MWI4MzU2Zi1iNTU5LTQ5ZGQtODJkYS1kNmRmOTI5NTE4NDMiLCJpc3MiOiJtb3ZpZV9wbHVzX3Rlc3QiLCJpYXQiOjE1OTMwMDE2NzAsIlVzZXJJZCI6IjQiLCJBY3RvckRhdGEiOiJ7XCJpZFwiOjQsXCJJZGVudGl0eVwiOlwiU3RlZmFuQGdtYWlsLmNvbVwiLFwiQWxsb3dlZFVzZUNhc2VzXCI6W119IiwibmJmIjoxNTkzMDAxNjcwLCJleHAiOjE1OTMwMDE3OTAsImF1ZCI6IkFueSJ9.TyY6qhKoh4EZhVG4W8NhdWoIDd81Q8hdoMOACTTc7co'
  },
  success: function(data) {
      $("#total").html(data.totalCount);

      let html = "";

      for(let item of data.items) {
        html += `<tr><td>${item.id}</td><td>${item.name}</td></tr>`
      }

      $("#body").html(html)

  },
  error: function(xhr, status, error) {

  }
});
}

function filterByName() {
    var name = $("#name").val()

    searchName = name;

    callApi();
}