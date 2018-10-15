<template lang="pug">
v-form(ref="form" v-model="valid" lazy-validation)
	v-container(fluid)
		v-layout(row wrap)
			v-flex(xs3)
				v-autocomplete(v-model="userId" :items="roads" label="開車路段" prepend-icon="directions")
			v-flex(xs3)
				v-autocomplete(v-model="userId" :items="types" label="統計種類" prepend-icon="receipt")
			v-flex(xs6)
				v-btn( :disabled="!valid" @click="findBillDetails")
					v-icon search
					| 查詢
				v-btn( @click="clear")
					v-icon clear
					| 清除
			v-flex(xs12)
				v-widget(title="時段營業額" content-bg="white")
					div(slot="widget-content")
						v-chart(:options="sample" style="height:428px;width:70%")
</template>

<script>
import VWidget from '@/components/VWidget';
import ECharts from 'vue-echarts/components/ECharts';
import 'echarts/lib/chart/bar';
import 'echarts/lib/chart/line';
import 'echarts/lib/component/polar';
import 'echarts/lib/component/tooltip';
export default {
	name: 'HourStatChart',
	components: { VWidget, 'v-chart': ECharts },
	props: {
		msg: String,
	},
	data() {
		return {
			userId: null,
			valid: false,
			roads: ['五福一路北側', '五福二路', '六合路', '六合一路', '七賢一路', '七賢二路'],
			types: ['時段營業額', '周間營業額'],
			sample: {
				legend: {},
				tooltip: {},
				color: ['#7AB'],
				dataset: {
					source: [
						['Time', '五福二路'], // 0=x軸名字，1...n=group
						['1', 0], // 0=x軸，1...n=group 的 y軸
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
						['23', 28182],
					],
				},
				xAxis: { type: 'category' },
				yAxis: {},
				series: [{ type: 'bar' }],
			},
			carNo: null,
			startDate: null,
			endDate: null,
			bills: [],
			condition: {},
		};
	},
};
</script>