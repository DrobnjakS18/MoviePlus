var searchName = null;

callApi();

function callApi() {

  let perPage = $("#perPage").val();
  
  let queryString = `ItemsPerPage=${perPage}`

  if(searchName != null) {
    queryString += `&Title=${searchName}`
  }

  $.ajax({
  url : `http://localhost:5101/api/movie?${queryString}`,
  headers : {
    'Authorization' : `Bearer ${window.sessionStorage.accessToken}`
  },
  success: function(data) {
      $("#total").html(data.totalCount);

      let html = "";

      for(let item of data.items) {
        html += `<div class="col-12 my-3 d-flex rounded">
                <div class="col-3">
                <img class="img-fluid my-4" src="images/blue-profile-image.jpg" alt="Movie image">
                </div>
                <div class="col-9 my-auto single-movie">
                  <h5><b>Title</b>: ${item.title}</h5>
                  <p><b>Descripiton:</b> ${item.description}</p>
                  <p><b>Duration</b>: ${item.duration}</p>
                  <p><b>Auditorium</b>: 1</p>
                  <p><b>Number of available tickets</b>: 5</p>
                  <button class="btn btn-primary">Buy Ticket</button>
                </div>
              </div>`;
      }

      let pages = `<ul class="list-group list-group-horizontal justify-content-center">`;

      for(var page = 1; page <= data.pageCount;page++){

        pages += `<li class="page list-group-item" data-page="${page}">${page}</li>`;
      }

      pages += `</ul>`;

      $(".movies").html(html);
      $('.pages').html(pages);


      pagination();

  },
  error: function(xhr, status, error) {
    alert("Application is not currently working. Please come back later");
  }
});
}

function filterByName() {
    var name = $("#name").val()

    searchName = name;

    callApi();
}

function pagination() {

  $('.page').on('click', function() {
    let clickedPage = $(this).data('page');

    let pagPerPage = $("#perPage").val();
  
    let pagQueryString = `ItemsPerPage=${pagPerPage}`
  
    if(searchName != null) {
      pagQueryString += `&Title=${searchName}`
    }
  
    pagQueryString += `&CurrentPage=${clickedPage}`;

    $.ajax({
      url : `http://localhost:5101/api/movie?${pagQueryString}`,
      headers : {
        'Authorization' : `Bearer ${window.sessionStorage.accessToken}`
      },
      success: function(data) {
          $("#total").html(data.totalCount);
    
          let html = "";
    
          for(let item of data.items) {
            html += `<div class="col-12 my-3 d-flex rounded">
                    <div class="col-3">
                    <img class="img-fluid my-4" src="images/blue-profile-image.jpg" alt="Movie image">
                    </div>
                    <div class="col-9 my-auto single-movie">
                      <h5><b>Title</b>: ${item.title}</h5>
                      <p><b>Descripiton:</b> ${item.description}</p>
                      <p><b>Duration</b>: ${item.duration}</p>
                      <p><b>Auditorium</b>: 1</p>
                      <p><b>Number of available tickets</b>: 5</p>
                      <button class="btn btn-primary">Buy Ticket</button>
                    </div>
                  </div>`;
          }
    
          let pages = `<ul class="list-group list-group-horizontal justify-content-center">`;
    
          for(var page = 1; page <= data.pageCount;page++){
    
            pages += `<li class="page list-group-item" data-page="${page}">${page}</li>`;
          }
    
          pages += `</ul>`;
    
          $(".movies").html(html);
          $('.pages').html(pages);
    
    
          pagination();
    
      },
      error: function(xhr, status, error) {
        alert("Application is not currently working. Please come back later");
      }
    });

  }); 
}

