//var CommentBox = React.createClass({
//    render: function () {
//        return (
//            <div className="commentBox">
//                Hello, world! This is viral jain.
//          </div>
//        );
//    }
//});
//ReactDOM.render(
//    <CommentBox />,
//    document.getElementById('nn')
//);  

var App = React.createClass({
    render: function () {
        return (
            <h1> Hello World! </h1>
        );
    }
});

React.render(<App />, document.getElementById('content'));