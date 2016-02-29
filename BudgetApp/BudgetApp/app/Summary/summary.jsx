
var Summary = React.createClass({
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
                        <label>$ {this.props.total}</label>
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