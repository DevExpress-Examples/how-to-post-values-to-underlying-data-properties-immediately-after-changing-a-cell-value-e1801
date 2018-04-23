# How to post values to underlying data properties immediately after changing a cell value


<p>To post values immediately, subscribe to the CellValueChanging event and call the View.PostEditor method.<br /><br /><em>If you don't want to handle events, check the <a href="https://www.devexpress.com/Support/Center/p/E4155">E4155 - How to make GridControl immediately save changes in a cell after editing</a> example demonstrating how to create a custom helper that does the entire job automatically.<br /><br /><strong>UPDATE: </strong>Starting with version 15.1, you can use the DataViewBase.EnableImmediatePosting property to post values to a data source without leaving an edited cell.</em></p>

<br/>


