
var Summary = React.createClass({
    getInitialState: function () {
        return { data: [] };
    },
    componentDidMount: function () {
        var data = loadAllUsersSummary();
        this.setState({ data: data });
    },
    loadDetails: function (userId) {
        alert("The id is:" + userId);
    },
    render: function () {
        return (
            <div className="summary">
                <div className="container">
                    <div className="row">
                        <HeaderCol header="Name" headerClass="col-md-6"></HeaderCol>
                        <HeaderCol header="Total Budget" headerClass="col-md-6"></HeaderCol>
                    </div>
                    <UserSummaryList data={this.state.data} getDetails={this.loadDetails}/>
                </div>            
            </div>
        );
    }
});

var HeaderCol = React.createClass({
    render: function () {
        return (
            <div className="headerCol">
                <div className={this.props.headerClass}>
                    <h3>{this.props.header}</h3>
                </div>
            </div>
        );
    }
});

var UserSummaryList = React.createClass({
    render: function () {
        var summaryNodes = this.props.data.map(function(userSummary){
            return(
                <UserSummary user={userSummary.Name} total={userSummary.TotalBudget }
                    handleClick={this.props.getDetails.bind(userSummary.UserId)}></UserSummary>
            );
        });
        return (
            <div className="row">
                <div className="userSummaryList">
                    {summaryNodes}
                </div>
            </div>
        );
    }
});

var UserSummary = React.createClass({
    render: function(){
        return( 
            <div className="userSummary">               
                <div className="col-md-6">
                    <label>{this.props.user}</label>
                </div>
                <div className="col-md-3">
                    <label>$ {this.props.total}</label>
                </div>
                <div className="col-md-3">
                    <label className="btn btn-primary" onClick={this.props.handleClick}>Details</label>
                </div>                
            </div>
        );
    }
});

/*var DetailsButton = React.createClass({
    render: function() {
        return(
            <div className="detailsButton">
                 <label className="btn btn-primary" onClick={this.props.handleClick}>Details</label>
            </div>
        );
    }
});*/

ReactDOM.render(
    <Summary />,
    document.getElementById('summaryContent')
);