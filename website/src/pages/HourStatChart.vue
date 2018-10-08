<template lang="pug">
v-form(ref="form" v-model="valid" lazy-validation)
	v-container(fluid)
		v-layout(row wrap)
			v-flex(xs3)
				v-autocomplete(v-model="userId" :items="roads" label="開車路段" prepend-icon="directions")
			v-flex(xs12)
				v-widget(title="時段營業額" content-bg="white")
					div(slot="widget-content")
						v-chart(:options="sample" style="height:450px;width:70%")
</template>

<script>
//- v-chart(:path-option=`[
//- 	['dataset.source', hourStat],
//- 	['xAxis.show', true],
//- 	['yAxis.show', true],
//- 	['grid.left', '2%'],
//-   ['grid.bottom', '5%'],
//-   ['grid.right', '3%'],
//- 	['series[0].type', 'bar']
//- 	['series[0].areaStyle', {}],
//-   ['series[0].smooth', true],
//- 	]` height="400px" width="100%")

//- e-chart(:path-option="[
//-           ['dataset.source', hourStat],
//-           ['color', [color.lightBlue.base, color.green.lighten1]],
//-           ['legend.show', true],
//-           ['xAxis.axisLabel.show', true],
//-           ['yAxis.axisLabel.show', true],
//-           ['grid.left', '2%'],
//-           ['grid.bottom', '5%'],
//-           ['grid.right', '3%'],
//-           ['series[0].type', 'bar'],
//-           ['series[0].areaStyle', {}],
//-           ['series[0].smooth', true],
//-           ['series[1].smooth', true],
//-           ['series[1].type', 'bar'],
//-           ['series[1].areaStyle', {}],
//-         ]" height="400px" width="100%")
import VWidget from '@/components/VWidget'
import ECharts from 'vue-echarts/components/ECharts'
import 'echarts/lib/chart/bar'
import 'echarts/lib/chart/line'
import 'echarts/lib/component/polar'
import 'echarts/lib/component/tooltip'
export default {
	name: 'HourStatChart',
	components: { VWidget, 'v-chart': ECharts },
	props: {
		msg: String
	},
	data() {
		return {
			userId: null,
			valid: false,
			roads: [
				'五福一路北側',
				'五福二路',
				'六合路',
				'六合一路',
				'七賢一路',
				'七賢二路'
			],
			sample: {
				legend: {},
				tooltip: {},
				color: ['#ADE'],
				dataset: {
					source: [
						['Product', '五福二路'],
						['1', 0],
						['2', 0],
						['3', 0],
						['4', 0],
						['5', 0],
						['6', 0],
						['7', 0],
						['8', 0],
						['9', 10000],
						['10', 18113],
						['11', 32286],
						['12', 66281],
						['13', 33510],
						['14', 31333],
						['15', 79471],
						['16', 71644],
						['17', 18473],
						['18', 84131],
						['19', 110011],
						['20', 34741],
						['21', 78731],
						['22', 11871],
						['23', 28182]
					]
				},
				xAxis: { type: 'category' },
				yAxis: {},
				series: [{ type: 'bar' }]
			},
			carNo: null,
			startDate: null,
			endDate: null,
			bills: [],
			condition: {}
		}
	}
}
</script>