
var Summary = React.createClass({
    //todo: this will pull the user name from a db table
    //todo: the budget total will be a calculated number from the data returned for all the debits and credits done in the
    //logic layer this will just get the value
    getInitialState: function () {
        return { data: [] };
    },
    componentDidMount: function () {
        var data = loadAllUsersSummary();
        this.setState({ data: data });
    },
    render: function () {
        return (
            <div className="summary">
                <div className="container">
                    <div className="row">
                        <HeaderCol header="Name" headerClass="col-md-6"></HeaderCol>
                        <HeaderCol header="Total Budget" headerClass="col-md-6"></HeaderCol>
                    </div>
                    <UserSummaryList data={this.state.data} />
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
                <UserSummary user={userSummary.Name} total={userSummary.TotalBudget}></UserSummary>
            );
        });
        return (
            <div className="userSummaryList">
                {summaryNodes}
            </div>
        );
    }
});

var UserSummary = React.createClass({
    render: function(){
        return( 
            <div className="userSummary">
                <div className="row">
                    <div className="col-md-6">
                        <label>{this.props.user}</label>
                    </div>
                    <div className="col-md-6">
                        <label>{this.props.total}</label>
                    </div>
                </div>
            </div>
        );
    }
});

ReactDOM.render(
    <Summary />,
    document.getElementById('summaryContent')
);

//todo: the above is structred wrong.
//summary component should get the data for the users and pass that to a child component
//the child component should setup a label and the data for the label

//the summary should get the budget totals and sum them up. done in the logic layer
//that should be another component.  It will get the data from the summary component.