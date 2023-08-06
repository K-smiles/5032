@Code
    ViewData("Title") = "testView"
End Code

<body>
    <h2>testView</h2>

    <div class="row">
        <div class="col-8">Content 1</div>
        <div class="col-4">Content 2</div>
    </div>

    <div class="row">
        <div class="col-12 col-sm-6 col-md-8">Content 1</div>
        <div class="col-6 col-md-4">Content 2</div>
    </div>


    <div class="row">
        <div class="col-sm">col-sm</div>
        <div class="col-sm">col-sm</div>
        <div class="col-sm">col-sm</div>
    </div>
    <div class="row">
        <div class="col-md-4">.col-md-4</div>
        <div class="col-md-4 offset-md-4">.col-md-4 .offset-md-4</div>
    </div>

    @Styles.Render("~/Content/testCss.css")
</body>
