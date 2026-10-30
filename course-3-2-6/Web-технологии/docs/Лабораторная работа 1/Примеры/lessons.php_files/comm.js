// JavaScript Document
function doLoad(value){
    err=document.getElementById('cerror');
	err.innerHTML = "<img src='pr.gif' width='100' height='9'><br><p>Ваш комментарий обрабатывается...</p>";
	// Create new JsHttpRequest object.
    var req = new JsHttpRequest();
    // Code automatically called on load finishing.
    req.onreadystatechange = function() {
        if (req.readyState == 4) {
		  if (req.responseJS.error == 'no') {
            // Clear error information.
            err.innerHTML = ' ';
			// Write req.responseJS to page element (_req.responseJS become responseJS). 
             comdiv=document.createElement('div')
			comdiv.innerHTML = '<table width="700" border="0" class="commcell"><tr><td style="width:80px;" valign="top"><img src="'+req.responseJS.avt+'" width="80" height="80" align="left" title="автар" alt="аватар" /></td><td><div class="commcell12"><img src="img/coma.jpg" width="20" height="20" style="left:1px !important; left:-20px;  top:14px; position:absolute;" /><div class="commcell2"><p><span class="comname">Автор: <strong>'+req.responseJS.name+'</strong></span>&nbsp;<span class="comdate">'+req.responseJS.date+'</span></p><p>'+req.responseJS.text+'</p></div></div></td></tr></table>';
			comment = document.getElementById('comtab');
			comment.appendChild(comdiv);
			form = document.getElementById('addcom');
			form.comtext.value = "";
          }
		  else
		  {
		  err.innerHTML = req.responseJS.er_mess;
		  }  	
        }
    }
    // Prepare request object (automatically choose GET or POST).
    req.open(null, 'comment.php', true);
    // Send data to backend.
    req.send( { q: value } );
}